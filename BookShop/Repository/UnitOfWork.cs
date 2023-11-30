using BookShop.Repository.IRepository;

namespace BookShop.Repository
{
	public class UnitOfWork : IUnitOfWork
	{
		public readonly IUnitOfWork unitOfWork;
		public ICategoryRepository categoryRepository { get; private set; }
		public IBookRepository bookRepository { get; private set; }
	}
}
