using System;
using System.Collections.Generic;
using System.Text;

namespace Musixmax.Models
{
    public class FolderItemModel
    {
        public string FolderPath { get; set; }
        public string FolderName { get; set; }
        public string FolderImage { get; set; } = "cover";
    }
}
