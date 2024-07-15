namespace BethanysPieShop.Models
{
    public class CategoryRepository: ICategoryRepository
    {
        private readonly BethanysPieShopDbContext _bethanysPieShopDbContext;

        public CategoryRepository(BethanysPieShopDbContext bethanysPieShopDbContext)
        {
            this._bethanysPieShopDbContext = bethanysPieShopDbContext;
        }

        public IEnumerable<Category> AllCategories => _bethanysPieShopDbContext.Categories.OrderBy(p => p.CategoryName);
        


    }
}
