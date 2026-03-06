using System.Text.Json.Serialization;

public class BenchmarkResponse

{
    [JsonPropertyName("benchmark_progress")]
    public double BenchmarkProgress { get; set; }
    [JsonPropertyName("overall_rank")]
    public int OverallRank { get; set; }
    [JsonPropertyName("categories")]
    public Dictionary<string, Category> Categories { get; set; } = new();
}

public class Category
{
    [JsonPropertyName("benchmark_progress")]
    public double BenchmarkProgress { get; set; }
    [JsonPropertyName("scenarios")]
    public Dictionary<string, ScenarioScore> Scenarios { get; set; } = new();
}

public class ScenarioScore
{
    [JsonPropertyName("score")]
    public double Score { get; set; }
    [JsonPropertyName("leaderboard_rank")]
    public int? LeaderboardRank { get; set; }
}