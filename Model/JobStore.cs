using System.Text.Json;

namespace blazor_job_applications.Model;

public class JobStore
{
    public required string Filename;

    public async Task<JobApplication[]> Load()
    {
        using FileStream readStream = File.OpenRead(Filename);
        var data = await JsonSerializer.DeserializeAsync<JobApplication[]>(readStream);
        if (data == null)
        {
            return [];
        }
        return data;
    }

    public async Task Save(JobApplication[] data)
    {
        await using FileStream createStream = File.Create(Filename);
        await JsonSerializer.SerializeAsync(createStream, data);
    }
}
