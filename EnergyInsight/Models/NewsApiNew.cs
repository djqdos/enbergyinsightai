
public class NewsApiNewResponse
{
    public string status { get; set; }
    public int totalResults { get; set; }
    public Result[] results { get; set; }
    public string nextPage { get; set; }
}

public class Result
{
    public string article_id { get; set; }
    public string title { get; set; }
    public string link { get; set; }
    public string[] keywords { get; set; }
    public string[] creator { get; set; }
    public object video_url { get; set; }
    public string description { get; set; }
    public string content { get; set; }
    public string pubDate { get; set; }
    public string image_url { get; set; }
    public string source_id { get; set; }
    public int source_priority { get; set; }
    public string source_url { get; set; }
    public string source_icon { get; set; }
    public string language { get; set; }
    public string[] country { get; set; }
    public string[] category { get; set; }
    public string ai_tag { get; set; }
    public string sentiment { get; set; }
    public string sentiment_stats { get; set; }
    public string ai_region { get; set; }
    public string ai_org { get; set; }
}
