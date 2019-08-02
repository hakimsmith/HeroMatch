export default function AllChars(game){
    return`
    <div class = "char-all">

    ${game.character.map (character => {
        return `
        <div class= "char-show-all">
        <a href= "${character.characterUrl}" target="_blank">
        <img src=${character.smallImage}>            
        <p>${character.name}</p>
        </a>
        </div>
        `
    }).join("")}
    </div>
    
    }
    `

}

