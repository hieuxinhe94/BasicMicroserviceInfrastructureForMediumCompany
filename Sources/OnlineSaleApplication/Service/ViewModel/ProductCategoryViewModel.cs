namespace Service.ViewModel
{
    public class ProductCategoryViewModel : BaseViewModel
    {
        public string CategoryName { get; set; }
        public int? ParentId { get; set; }
        public string ImgUrl { get; set; }
        public string Description { get; set; }
    }
}
