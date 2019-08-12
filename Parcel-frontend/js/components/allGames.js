export default function AllGames(games){
    return `
    <div class='allGames'>
    <h1 >Games</h1>
    
        ${games.map(game => {
        return `
            <div class='gameList'>
                <img class='gameName' src="${game.image}">
                <h2 class='gameName'>${game.name}</h2>
                <input class='game__id' type='hidden' value="${game.gameId}">
            </div>
            `;
        })
        .join("")}
    
    </div>        
    `
}