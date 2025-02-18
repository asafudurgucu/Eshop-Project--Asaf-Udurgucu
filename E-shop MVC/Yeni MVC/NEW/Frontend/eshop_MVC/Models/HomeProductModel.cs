using eshop_MVC.Models.SettingsModels;

namespace eshop_MVC.Models
{
    public class HomeProductModel
    {

        public IEnumerable<ProductModel> Products { get; set; }
        public IEnumerable<CategoryModel> Categories { get; set; }
        public IEnumerable<GetSettingsModel> Settings { get; set; }
    }
}
