using System;
using System.Collections.Generic;
using System.Linq;
using LiftThingsAPI.Core.Models;

namespace LiftThingsAPI.ApiModels
{
    public static class ExerciseMappingExtensions
    {
		public static ExerciseModel ToApiModel(this Exercise exercise)
		{
			return new ExerciseModel
			{
				Id = exercise.Id,
				ExerciseName = exercise.ExerciseName,
                MuscleGroup = exercise.MuscleGroup,
                Notes = exercise.Notes,
                RoutineId = exercise.RoutineId,
			};
		}

		public static Exercise ToDomainModel(this ExerciseModel exerciseModel)
		{
			return new Exercise
			{
				Id = exerciseModel.Id,
				ExerciseName = exerciseModel.ExerciseName,
				MuscleGroup = exerciseModel.MuscleGroup,
				Notes = exerciseModel.Notes,
				RoutineId = exerciseModel.RoutineId,
			};
		}

		public static IEnumerable<ExerciseModel> ToApiModels(this IEnumerable<Exercise> exercises)
		{
			return exercises.Select(a => a.ToApiModel());
		}

		public static IEnumerable<Exercise> ToDomainModels(this IEnumerable<ExerciseModel> exerciseModels)
		{
			return exerciseModels.Select(a => a.ToDomainModel());
		}
	}
}

