﻿/*
  Hlab.Base
  Copyright (c) 2017 Mathieu GRENET.  All right reserved.

  This file is part of Hlab.Base.

    Hlab.Base is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Hlab.Base is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with MouseControl.  If not, see <http://www.gnu.org/licenses/>.

	  mailto:mathieu@mgth.fr
	  http://www.mgth.fr
*/
namespace Hlab.Base
{
    public interface IService { }


    //public class Service
    //{
    //    private static readonly ConcurrentDictionary<Type, IService> Services = new ConcurrentDictionary<Type, IService>();

    //    public static T Get<T>()
    //        where T :IService, new()
    //    {
    //        return (T)Services.GetOrAdd(typeof(T), e => new T());
    //    }

    //    public static IService Get(Type type)
    //    {
    //        return Services.GetOrAdd(type, t => (IService)Activator.CreateInstance(t) );          
    //    }
    //}
}
