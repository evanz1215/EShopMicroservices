using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Orders.Commands.DeleteOrder;

public record class DeleteOrderCommand(Guid Id) : ICommand<DeleteOrderResult>;
public record class DeleteOrderResult(bool IsSuccess);


public class DeletOrderCommandValidator : AbstractValidator<DeleteOrderCommand>
{
    public DeletOrderCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty().WithMessage("OrderId is required.");
    }
}
