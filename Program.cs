using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

class Hello {
    public static async Task<String> Lookup() {
        var wc = new HttpClient();
        var uri = new Uri("https://5b9a3ca9d203ad0014619c71.mockapi.io/posts");

        return await wc.GetStringAsync(uri);
    }
}

public class Payload {
    public int Id { get; set; }

    public string Title { get; set; }

    public string Body { get; set; }

    public int UserId { get; set; }
}

static class Program {
    private static void Main(string[] args) {
        var json = Hello.Lookup().Result;
        Console.WriteLine(json);

        var results = JsonConvert.DeserializeObject<IEnumerable<Payload>>(json);

        foreach (var result in results) {
            Console.WriteLine("{0} {1} {2} {3}", result.Id, result.Title, result.Body, result.UserId);
        }
    }
}