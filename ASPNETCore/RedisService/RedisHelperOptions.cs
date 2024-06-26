﻿using System.ComponentModel.DataAnnotations;

namespace ASPNETCore.RedisService;

public class RedisHelperOptions
{
    [Required(ErrorMessage = "redis connection string is required")]
    public string ConnectionString { get; set; }

    [Range(0, 15, ErrorMessage = "redis db number must be between 0 and 15")]
    public int DbNumber { get; set; }

    public RedisHelperOptions()
    {
    }

    public RedisHelperOptions(string connectionString, int dbNumber)
    {
        ConnectionString = connectionString;
        DbNumber = dbNumber;
    }
}