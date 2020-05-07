using AutoMapper;
using BEProjectEllen.API.DataTransferObjects;
using BEProjectEllen.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BEProjectEllen.API.Mapping
{
    public class QuizProfile : Profile
    {

        public QuizProfile()
        {
            // domain class --> api DTO

            CreateMap<Quiz, QuizDTO>()
                //difficulty van Difficulty komt overeen met het Level property van Quiz
                .ForMember(dest => dest.Difficulty, opt => opt.MapFrom(src => src.Difficulty.Level))
                ;

            CreateMap<Question, QuestionDTO>();
            CreateMap<Question, QuestionWithAnswersDTO>();
            CreateMap<Question, QuestionWithoutAnswersDTO>();

            CreateMap<Choice, ChoiceWithoutAnswersDTO>();
            CreateMap<Choice, ChoiceDTO>();



            // api DTO --> domain class
            CreateMap<SaveQuizDTO, Quiz>()
              .ForMember(dest => dest.Id, opt => opt.Ignore());

            CreateMap<QuestionDTO, Question>()
              .ForMember(dest => dest.Id, opt => opt.Ignore());

            CreateMap<QuestionWithAnswersDTO, Question>()
              .ForMember(dest => dest.Id, opt => opt.Ignore());

            CreateMap<ChoiceDTO, Choice>()
              .ForMember(dest => dest.Id, opt => opt.Ignore());

        }
    }
}
