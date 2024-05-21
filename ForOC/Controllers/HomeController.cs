using Microsoft.AspNetCore.Mvc;

namespace ForOC.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : Controller
    {

        [HttpGet]
        public ActionResult Index()
        {
            return new ContentResult
            {
                ContentType = "text/html",
                Content = "<!DOCTYPE html>\r\n<html lang=\"en\">\r\n<head>\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=\\, initial-scale=1.0\">\r\n    <title>Document</title>\r\n</head>\r\n<body>\r\n    <a href=\"api/healthcheck\">Проверить состояние</a>\r\n    <a href=\"api/products\">Получить все продукты</a>\r\n    <a href=\"/api/customers\">Получить всех клиентов</a>\r\n</body>\r\n</html>"
            };
        }
    }
}
