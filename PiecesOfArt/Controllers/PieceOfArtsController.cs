using Microsoft.AspNetCore.Mvc;
using PiecesOfArt.DTOs;
using PiecesOfArt.Interface;
using PiecesOfArt.Models;
using System.Threading.Tasks;

namespace PiecesOfArt.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PieceOfArtsController : ControllerBase
    {
        private readonly IPieceOfArtRepository _pieceOfArtRepository;

        public PieceOfArtsController(IPieceOfArtRepository pieceOfArtRepository)
        {
            _pieceOfArtRepository = pieceOfArtRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPieces()
        {
            var pieces = await _pieceOfArtRepository.GetAllAsync();
            return Ok(pieces);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPieceById(int id)
        {
            var piece = await _pieceOfArtRepository.GetByIdAsync(id);
            if (piece == null)
            {
                return NotFound();
            }
            return Ok(piece);
        }

        [HttpPost]
        public async Task<IActionResult> AddPiece([FromBody] DTO_Piecesofart pieceDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var piece = new PieceOfArt
            {
                Title = pieceDto.Title,
                Price = pieceDto.Price,
                PublicationDate = pieceDto.PublicationDate,
                CategoryId = pieceDto.CategoryId
            };
            await _pieceOfArtRepository.AddAsync(piece);
            return CreatedAtAction(nameof(GetPieceById), new { id = piece.Id }, piece);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePiece(int id, [FromBody] DTO_Piecesofart pieceDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var piece = await _pieceOfArtRepository.GetByIdAsync(id);
            if (piece == null)
            {
                return NotFound();
            }

            piece.Title = pieceDto.Title;
            piece.Price = pieceDto.Price;
            piece.PublicationDate = pieceDto.PublicationDate;
            piece.CategoryId = pieceDto.CategoryId;

            await _pieceOfArtRepository.UpdateAsync(piece);
            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePiece(int id)
        {
            var piece = await _pieceOfArtRepository.GetByIdAsync(id);
            if (piece == null)
            {
                return NotFound();
            }

            await _pieceOfArtRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
