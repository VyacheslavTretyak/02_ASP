using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountControl
{
	public interface IRepository<T, i>
	{
		void Create(T item);
		void Update(T item);
		bool Delete(i val);
		T Get(i val);
		IEnumerable<T> GetAll();
		bool IsInit { get; set; }
	}
}