namespace Service.ViewModel
{
    public class NavigationViewModel : BaseViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Index { get; set; }
        public int? ParentId { get; set; }
        public NavigationViewModel Parent { get; set; }
    }
}
