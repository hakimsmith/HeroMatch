export default function CharacterResult(characters){
    return `
    <ul>

    ${characters.map(character =>{

            return `
        <li>
            <img src=${character.image}>
            <p>${character.name}</p>

        </li>
        `        
        }

    )
    }).join("")}
    </ul>
    `
}