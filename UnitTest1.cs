using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CapaModelo;
using CapaControl;

namespace PruebaUnitaria
{
    class UnitTest1
    {
		[TestClass]
		public class UnitTest1
		{
			DProducto prod = new DProducto();

			[TestMethod]
			public void Test_IdProducto()
			{
				bool restriccion;
				string expresion = @“[A-Za - z0 - 9]”;
				int valor;
				valor = prod.IdProducto;
				System.Text.RegularExpressions.Regex re = new Regex(expresion);
				restriccion = re.IsMatch(valor.ToString());
				Assert.AreEqual(restriccion, true);
			}

			[TestMethod]
			public void Test_Nombre()
			{
				bool restriccion;
				string expresion = @“[A-zA - Z]”;
				string valor;
				valor = prod.Nombre;
				System.Text.RegularExpressions.Regex re = new Regex(expresion);
				restriccion = re.IsMatch(valor.ToString());
				Assert.AreEqual(restriccion, true);
			}

			[TestMethod]
			public void Test_Precio()
			{
				bool restriccion;
				string expresion = @“[a-z]”;
				int valor;
				valor = prod.Precio;
				System.Text.RegularExpressions.Regex re = new Regex(expresion);
				restriccion = re.IsMatch(valor.ToString());
				Assert.AreEqual(restriccion, true);
			}

			[TestMethod]
			public void Test_Tipo()
			{
				bool restriccion;
				string expresion = @“[0-9]”;
				string valor;
				valor = prod.Tipo;
				System.Text.RegularExpressions.Regex re = new Regex(expresion);
				restriccion = re.IsMatch(valor.ToString());
				Assert.AreEqual(restriccion, true);
			}
		}
	}
}
