﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Customer.Presenter
{
    class DatabaseHelper
    {
        public static readonly string connectionString = ConfigurationManager.ConnectionStrings["FoodiePointDB"].ConnectionString;
    }
}
