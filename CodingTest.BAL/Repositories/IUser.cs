﻿using CodingTest.BAL.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.BAL.Repositories
{
  public  interface IUser
    {
        User Authenticate(string username, string password);
      
    }
}
