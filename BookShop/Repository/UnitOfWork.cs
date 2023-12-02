using BookShop.Data;
using BookShop.Repository.IRepository;

namespace BookShop.Repository
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly ApplicationDBContext _dbContext;
		public ICategoryRepository CategoryRepository { get; private set; }

		public IBookRepository BookRepository { get; private set; }
		public UnitOfWork(ApplicationDBContext dBContext)
		{
			_dbContext = dBContext;
			CategoryRepository = new CategoryRepository(dBContext);
			BookRepository = new BookRepository(dBContext);
		}
		public void Save()
		{
			_dbContext.SaveChanges();
		}
	}
}