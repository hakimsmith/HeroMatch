export default function Home(games){
    return `
    <h1>Pick a Game</h1>
    <ul class='main-flex'>
        ${games.map(game => {
        return `
            <li>
                <img class='select-game' src="${game.image}">
                <p>${game.name}</p>
                <input class='select-game__id' type='hidden' value="${game.gameId}">
            
            </li>
            `;
        })
        .join("")}
    </ul>
        
    `
}