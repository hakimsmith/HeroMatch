export default function CharacterResult(characters, aesthetic){
    characters.sort(function(a,b){
        if(b.aesthetic == aesthetic){
            return 1
        }
        return a.aesthetic - b.aesthetic
    })
    return `
   <div class = "char-results">
    ${characters.map(character =>{
        if(character.aesthetic == aesthetic && characters.indexOf(character) == 0)
        return `
        <div class= "char-single-result">
            <img class='single-char' src=${character.image}>            
            <p class='single-char-name'>${character.name}</p>
            <input class='gameid' value=${character.gameId} type='hidden'>
            <input class='apiLocation' value=${character.apiLocation} type='hidden'>
            <input class='video' value=${character.video} type = 'hidden'>
            <input class='image' value=${character.image} type ='hidden'>
        </div>
        `
        else
        return `
        <div class='char-other-result'>
            <img class='single-char' src=${character.smallImage}>            
            <p class='single-char-name'>${character.name}</p>
            <input class='gameid' value=${character.gameId} type='hidden'>
            <input class='apiLocation' value=${character.apiLocation} type='hidden'>
            <input class='video' value=${character.video} type = 'hidden'>
            <input class='image' value=${character.image} type ='hidden'>
        </div>
        `   

    }).join("")}
   </div>
   <button value='${characters[0].gameId }' class="allChar">View All Characters</button>
   <button class='switch-game'>View Similar Characters for Other Game</button>
    `
}