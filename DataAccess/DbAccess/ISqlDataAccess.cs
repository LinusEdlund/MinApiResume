﻿namespace DataAccess.DbAccess;

public interface ISqlDataAccess
{
  Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionId = "Default");
}