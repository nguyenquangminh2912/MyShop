using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyShop.Data.Infrastructer;
using MyShop.Data.Repositories;
using MyShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.UnitTest.RepositoryTest
{
    [TestClass]
    public class PostCategoryRepositoryTest
    {
        IDbFactory dbFactory;
        IPostCategoryRepository objRepository;
        IUnitOfWork unitOfWork;

        [TestInitialize]
        public void Initialize()
        {
            //Initialize : đây là phương thức khới chạy đầu tiên.
            //Khởi tạo 3 phương thức này trước.
            dbFactory = new DBFactory();
            objRepository = new PostCategoryRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }

        [TestMethod]
        public void PostCategory_Repository_GetAll()
        {
            var list =  objRepository.GetAll().ToList();
            Assert.AreEqual(3, list.Count);
        }

        [TestMethod]
        public void PostCategory_Repository_Create()
        {
            PostCategory category = new PostCategory();
            category.Name = "Test category";
            category.Alias = "Test-category";
            category.Status = true;

            var result = objRepository.Add(category);
            unitOfWork.Commit();

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.ID);
        }

    }
}
