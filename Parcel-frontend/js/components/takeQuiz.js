export default function TakeQuiz(games){
    return `
    <h1>Pick a Game</h1>
    <div class='main-flex'>
        ${games.map(game => {
        return `
            <div>
                <img class='select-game' src="${game.image}">
                <p>${game.name}</p>
                <input class='select-game__id' type='hidden' value="${game.gameId}">
            </div>
            `;
        })
        .join("")}
    </div>
        
    `
}