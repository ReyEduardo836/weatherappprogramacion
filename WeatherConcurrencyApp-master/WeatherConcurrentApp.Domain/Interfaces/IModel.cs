using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherConcurrentApp.Domain.Interfaces
{
    public interface IModel<T>
    {
        int Create();
        List<T> Read();
        bool Update();
        bool Delete();
    }
}
