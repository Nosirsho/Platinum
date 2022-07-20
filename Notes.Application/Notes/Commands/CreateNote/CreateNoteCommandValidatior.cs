using System;
using FluentValidation;
using System.Threading.Tasks;

namespace Notes.Application.Notes.Commands.CreateNote {
	public class CreateNoteCommandValidatior : AbstractValidator<CreateNoteCommand>{
		public CreateNoteCommandValidatior() {
			RuleFor(createNoteCommand => createNoteCommand.Title).MaximumLength(250);
			RuleFor(createNoteCommand => createNoteCommand.UserId).NotEqual(Guid.Empty);
		}
	}
}
