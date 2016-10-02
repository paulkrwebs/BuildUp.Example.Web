using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildUp.Example.Web
{
    public class PropertyMapper : IPropertyMapper
    {
        public void Map<TFrom, TTo>(TFrom from, TTo to)
        {
            Mapper.Map(from, to);
        }
    }
}