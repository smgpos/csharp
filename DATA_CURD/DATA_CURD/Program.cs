using System;
using System.Collections.Generic;

namespace DATA_CURD
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ITodoRepository _repository = new TodoRepository();
            List<PLU> PLUs = new List<PLU>();
            PLUs = _repository.GetAll();

            foreach (PLU plu in PLUs)
            {
                Console.WriteLine($"Barcode: {plu.Barcode}, Name: {plu.Name}, Price: {plu.Price}");
            }

            PLU pLU = new PLU { Name = "leeky", Price = 999_999_999 };
            _repository.Add(pLU);

            PLUs = _repository.GetAll();
            foreach (PLU plu in PLUs)
            {
                Console.WriteLine($"Barcode: {plu.Barcode}, Name: {plu.Name}, Price: {plu.Price}");
            }


        }
    }
}
