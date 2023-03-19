using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HtmlAgilityPack;
using System.Net;
using System.Text;
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Model;
using System.Reflection;
using VkNet.Model.RequestParams;
using VkNet.Enums.SafetyEnums;

namespace _8March.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; private set; } = "PageModel in C#";
        public string[] ImgUrls { get; private set; }

        private VkApi _api = new VkApi();
        private string _token = @"vk1.a.wz6AbjpQSyGAdu8zXTpdI4WxvBiGXTsVEh-M7qzxkDyDxHNrGGwMqCp391VhA7nRTzfiSkb8XcenGfiEVs5UAXulniuSt4OdO75SzhtozHTKZ1yqDYivdGSBZLscVrWilE99QUQPIbie_
                    kPIx0nXDq57Iv_j03JDXwbRHLHetBnRhuszDIgIZDcKtUWo7gK2_3fg6dDKHe5NxD0HohMrVA";
        public string ParsedHtml { get; private set; } = string.Empty;

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            // сначала запускаю закомментированный код и получаю токен
            // после комменчу 
            //_api.Authorize(new ApiAuthParams
            //{
            //    ApplicationId = 51584679,
            //    Login = "",
            //    Password = "",
            //    Settings = Settings.All
            //});

            //_token = _api.Token;
            _api.Authorize(new ApiAuthParams { AccessToken = _token });
            _logger = logger;
        }

        public void OnGet()
        {

            //var url = @$"https://vk.com/id671760024?z=photo671760024_457239809%2Falbum671760024_000?access_token={_token}";
            //url = @"https://habr.com/ru/post/314518/";


            var v = _api.Status.Get(671760024);
            var g = _api.Photo.Get(new PhotoGetParams 
                { 
                    Count = 10,
                    OwnerId = 671760024,
                    AlbumId=PhotoAlbumType.Profile,
                    Reversed= true,
            });

            var l = g.Select(x => x.Sizes).ToList();
            var s = l.Select(x => x.OrderByDescending(x => x.Width).FirstOrDefault());
            ImgUrls = s.Select(x=>x.Url.AbsoluteUri).ToArray();

            //Console.WriteLine(ImgUris[0].ToString());
            //Console.WriteLine(ImgUris[0].AbsoluteUri);
            //Console.WriteLine(ImgUris[0].Scheme);

        }
    }
}