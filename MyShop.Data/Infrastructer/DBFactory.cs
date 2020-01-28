namespace MyShop.Data.Infrastructer
{
    public class DBFactory : Disposable, IDbFactory
    {
       private MyShopDBContext dbcontext;
        public MyShopDBContext Init()
        {
            return dbcontext ?? (dbcontext = new MyShopDBContext());
            //Nếu Null thì sẽ khởi tạo dbcontext
        }
        protected override void DisposeCore()
        {
            if(dbcontext != null)
            dbcontext.Dispose(); //Nếu khác Null thì Dispose
        }

    }
}
