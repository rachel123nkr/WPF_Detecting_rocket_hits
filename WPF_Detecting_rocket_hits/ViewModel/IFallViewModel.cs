using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.ViewModel
{
    public interface IFallViewModel
    {
        void showFallFrom();
        void AddNewFallWithAddress();
        void AddNewFallWithImage();
        void loadImg();
    }
}
