//using System;
//using System.Collections.Generic;
//using System.Linq;
//using LiftThingsAPI.Core.Models;

//namespace LiftThingsAPI.ApiModels
//{
//    public static class UserMappingExtensions
//    {
//		public static UserModel ToApiModel(this User user)
//		{
//			return new UserModel
//			{
//				Id = user.Id,
//				FirstName = user.FirstName,
//				Email = user.Email,
//			};
//		}

//		public static User ToDomainModel(this UserModel userModel)
//		{
//			return new User
//			{
//                Id = userModel.Id,
//				FirstName = userModel.FirstName,
//				Email = userModel.Email,
//			}
//		}

//		public static IEnumerable<UserModel> ToApiModels(this IEnumerable<User> users)
//		{
//			return users.Select(a => a.ToApiModel());
//		}

//		public static IEnumerable<User> ToDomainModels(this IEnumerable<UserModel> userModels)
//		{
//			return userModels.Select(a => a.ToDomainModel());
//		}
//	}
//}
