using System;
using System.Collections.Generic;
using System.Linq;
using LiftThingsAPI.Core.Models;

namespace LiftThingsAPI.ApiModels
{
    public static class RoutineMappingExtensions
    {
		public static RoutineModel ToApiModel(this Routine routine)
		{
			return new RoutineModel
			{
				Id = routine.Id,
				RoutineName = routine.RoutineName,
                Date = routine.Date,
                UserId = routine.UserId,
                Exercises = routine.Exercises,
			};
		}

		public static Routine ToDomainModel(this Routine routineModel)
		{
			return new Routine
			{
				Id = routineModel.Id,
				RoutineName = routineModel.RoutineName,
				Date = routineModel.Date,
				UserId = routineModel.UserId,
				User = routineModel.User,
				Exercises = routineModel.Exercises,
			};
		}

		public static IEnumerable<RoutineModel> ToApiModels(this IEnumerable<Routine> routines)
		{
			return routines.Select(a => a.ToApiModel());
		}

		public static IEnumerable<Routine> ToDomainModels(this IEnumerable<RoutineModel> routineModels)
		{
			return routineModels.ToDomainModels();
		}
	}
}

