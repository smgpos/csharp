using System.Collections.Generic;
using System.Linq;

namespace DATA_CURD
{
    public class TodoRepository : ITodoRepository
    {
        private static List<PLU> _PLUs; // = new List<PLU>();

        public TodoRepository()
        {
            _PLUs = new List<PLU>
            {
                new PLU { Name = "품명", Barcode = "123", Price = 1_234},
                new PLU { Name = "품명2", Barcode = "1234", Price = 12_345},
                new PLU { Name = "품명3", Barcode = "12345", Price = 123_456}
            };

        }

        public void Add(PLU item)
        {
            item.Barcode = _PLUs.Max(t => t.Barcode);  
            _PLUs.Add(item);

        }

        public List<PLU> GetAll()
        {
            return _PLUs.ToList();
        }

        public void Delete(PLU item)
        {            
        }

        public void Update(PLU item)
        {            
        }
    }

}
