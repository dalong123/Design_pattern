using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IProductClass;
using System.Configuration;
using System.Reflection;


using AbstractProduct;
namespace ConsoleApplication1
{
    public static class Factory
    {
         
        public static IProduct  GetProduct(string  parames) {

            IProduct product=null;
            
            product = (IProduct)System.Reflection.Assembly.GetExecutingAssembly().CreateInstance(System.Configuration.ConfigurationManager.AppSettings.Get(parames), false);
            if (product == null)
            {
                throw new NotImplementedException("对应的类暂时没实现");
            }
            return product;
        }
        public static AbstractProduct.AbstractProduct GetProduct2(string parames)
        {

            AbstractProduct.AbstractProduct product = null;

            var namespaceinfo = parames.Substring(0,parames.IndexOf("."));
            var calssname = parames.Substring(parames.LastIndexOf(".")+1, parames.Length - parames.LastIndexOf(".")-1);
            try
            {
                Assembly asb = System.Reflection.Assembly.LoadFrom(namespaceinfo + ".dll");

                product = (AbstractProduct.AbstractProduct)asb.CreateInstance(ConfigurationManager.AppSettings.Get(parames), false);

                //  product = (IProduct2)System.Reflection.Assembly.GetExecutingAssembly().CreateInstance(ConfigurationManager.AppSettings.Get(parames), false);
            
            }
            catch (Exception ex)
            {
                LogHelper.LogHelper.WriteErrLog(typeof(Factory), ex.ToString());
            }
          
            return product;
        }
    }
}
