﻿namespace ApiQuala.Dtos
{
    public class UpdateBranchDto
    {

       
        public string Description { get; set; }
        public string Address { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;

        public int CoinId { get; set; }
    }
}
