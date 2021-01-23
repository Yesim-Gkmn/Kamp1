using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    { //encapsulation
        public void Add( Product product)
        {
            Console.WriteLine(product.ProductName+ "eklendi");
        
        }
        public void Update(Product product) 
        {
            Console.WriteLine(product.ProductName+ "güncellendi");
        
        }

       
    }
} 


//int.double,boll...değertip
//diziler,class,abstract class,interface ... referans tip
