using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
public class CustomerController : ControllerBase
{
    private readonly VSMContext _context;

    public CustomerController(VSMContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
    {
        return await _context.Customers.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Customer>> PostCustomer(Customer customer)
    {
        _context.Customers.Add(customer);
        await _context.SaveChangesAsync();
        return CreatedAtAction("GetCustomer", new { id = customer.CustomerId }, customer);
    }
}