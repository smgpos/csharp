using System.Collections.Generic;

namespace DATA_CURD
{
    public interface ITodoRepository
    {
        void Add(PLU item);
        List<PLU> GetAll();
        void Update(PLU item);
        void Delete(PLU item);  
        
    }

}
