﻿using AppVacances.Models;
using AppVacances.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppVacances.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewProfile : ContentView
    {
        public NewProfile(ObservableCollection<User> users, User user)
        {
            InitializeComponent();
            BindingContext = new PageUserViewModel(users, user);
        }

        //User newUser = new User();
        //ProfileViewModel pvm = new ProfileViewModel(newUser);

        public bool SaveAllowed =>
    !string.IsNullOrEmpty(nom.Text) && !string.IsNullOrEmpty(desc.Text);

    }
}