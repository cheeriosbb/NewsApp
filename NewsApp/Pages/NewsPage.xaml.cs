using NewsApp.Models;
using NewsApp.Services;

namespace NewsApp.Pages;

public partial class NewsPage : ContentPage
{
    public List<Article> ArticlesList { get; set; }
	public NewsPage()
	{
		InitializeComponent();
        ArticlesList = new List<Article>();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        ApiServices apiService = new ApiServices();
        var newsResult = await apiService.GetNews();
        foreach ( var item in newsResult.Articles )
        {
            ArticlesList.Add(item);
        }
        CvNews.ItemsSource = ArticlesList;
    }
}