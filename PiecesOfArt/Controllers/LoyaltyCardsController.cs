using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using PiecesOfArt.Interface;
using PiecesOfArt.Models;

[Route("api/[controller]")]
[ApiController]
public class LoyaltyCardsController : ControllerBase
{
    private readonly ILoyaltyCardRepository _loyaltyCardRepository;

    public LoyaltyCardsController(ILoyaltyCardRepository loyaltyCardRepository)
    {
        _loyaltyCardRepository = loyaltyCardRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<LoyaltyCard>>> GetAllLoyaltyCards()
    {
        var loyaltyCards = await _loyaltyCardRepository.GetAllAsync();
        return Ok(loyaltyCards);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<LoyaltyCard>> GetLoyaltyCardById(int id)
    {
        var loyaltyCard = await _loyaltyCardRepository.GetByIdAsync(id);
        if (loyaltyCard == null)
        {
            return NotFound();
        }
        return Ok(loyaltyCard);
    }

    [HttpPost]
    public async Task<ActionResult<LoyaltyCard>> CreateLoyaltyCard(LoyaltyCard loyaltyCard)
    {
        await _loyaltyCardRepository.AddAsync(loyaltyCard);
        return CreatedAtAction(nameof(GetLoyaltyCardById), new { id = loyaltyCard.Id }, loyaltyCard);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateLoyaltyCard(int id, LoyaltyCard loyaltyCard)
    {
        if (id != loyaltyCard.Id)
        {
            return BadRequest();
        }

        await _loyaltyCardRepository.UpdateAsync(loyaltyCard);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteLoyaltyCard(int id)
    {
        var loyaltyCard = await _loyaltyCardRepository.GetByIdAsync(id);
        if (loyaltyCard == null)
        {
            return NotFound();
        }

        await _loyaltyCardRepository.DeleteAsync(id);
        return NoContent();
    }
}
