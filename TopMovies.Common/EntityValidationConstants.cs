﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopMovies.Common
{
    public static class EntityValidationConstants
    {
        public class Movie
        {
            public const int NameMinLength = 1;
            public const int NameMaxLength = 40;

            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 500;

            public const string RatingMin = "1";
            public const string RatingMax = "10";

        }

        public class Genre
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 20;
        }

        public class Actor
        {
			public const int NameMinLength = 1;
			public const int NameMaxLength = 30;

			public const int DescriptionMinLength = 10;
			public const int DescriptionMaxLength = 10000;
		}

		public class MovieCharacter
		{
			public const int NameMinLength = 1;
			public const int NameMaxLength = 10;

			public const int DescriptionMinLength = 30;
			public const int DescriptionMaxLength = 5000;

		}

        public class UserReview
        {
            public const int RatingMin = 1;
            public const int RatingMax = 10;

            public const int CommentMinLength = 10;
            public const int CommentMaxLength = 1000;

        }
	}
}
