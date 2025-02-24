﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM_DB_Example.DialogService.Defines.Interfaces

{
    public interface IDialog // Window interface
    {
        object DataContext { get; set; }
        void Show();

        bool? ShowDialog();

        void Close();

        // 추가로 Window 타입을 사용하려면 이 인터페이스를 파생시킨다.
    }
}
