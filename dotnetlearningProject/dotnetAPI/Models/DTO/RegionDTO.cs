﻿using dotnetAPI.Models.Domain;

namespace dotnetAPI.Models.DTO
{
    public class RegionDTO
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public double Area { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public double Population { get; set; }

        //Navigation Property
        public IEnumerable<Walk> Walks { get; set; }
    }
}
