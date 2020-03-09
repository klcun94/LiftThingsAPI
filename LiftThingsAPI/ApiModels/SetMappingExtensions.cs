using System;
using System.Collections.Generic;
using System.Linq;
using LiftThingsAPI.Core.Models;

namespace LiftThingsAPI.ApiModels
{
    public static class SetMappingExtensions
    {
		public static SetModel ToApiModel(this Set set)
		{
			return new SetModel
			{
				Id = set.Id,
                RoutineId = set.RoutineId,
                ExcerciseId = set.ExcerciseId,
                Weight = set.Weight,
                RepetitionsCount = set.RepetitionsCount,
			};
		}

		public static Set ToDomainModel(this SetModel setModel)
		{
			return new Set
			{
				Id = setModel.Id,
                RoutineId = setModel.RoutineId,
                ExcerciseId = setModel.ExcerciseId,
                Weight = setModel.Weight,
                RepetitionsCount = setModel.RepetitionsCount,
			};
		}

		public static IEnumerable<SetModel> ToApiModels(this IEnumerable<Set> sets)
		{
			return sets.Select(a => a.ToApiModel());
		}

		public static IEnumerable<Set> ToDomainModels(this IEnumerable<SetModel> setModels)
		{
			return setModels.Select(a => a.ToDomainModel());
		}
	}
}
