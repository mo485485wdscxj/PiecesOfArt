namespace PiecesOfArt.Interface
{
    public interface IPieceOfArtRepository
    {
        Task<PieceOfArt> GetByIdAsync(int id);
        Task<IEnumerable<PieceOfArt>> GetAllAsync();
        Task AddAsync(PieceOfArt pieceOfArt);
        Task UpdateAsync(PieceOfArt pieceOfArt);
        Task DeleteAsync(int id);
    }
}
