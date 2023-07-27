using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContinuousDelivery.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;
		private readonly IConfiguration _configuration;

		public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
		{
			_logger = logger;
			_configuration = configuration;
		}

		public void OnGet()
		{
			//throw new Exception("Testing Insights");
			ViewData["Greeting"] = _configuration["Greeting"];
		}
	}
}