using DesignPatterns.Command.FX;

namespace DesignPatterns.Command;

public class AddCustomerCommand : ICommand
{
    #region Fiedls

    private readonly CustomerService _customerService;

    #endregion

    #region Constructor

    public AddCustomerCommand(CustomerService customerService)
    {
        _customerService = customerService;
    }

    #endregion

    #region Execute

    public void Execute()
    {
        _customerService.AddCustomer();
    }

    #endregion
}