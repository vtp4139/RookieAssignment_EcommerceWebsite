import {SET_USER} from "../constans/user.types"

const defaultState = {
    user: {}
}

export default (state = defaultState, action)=>{
    switch (action.type) {
        case SET_USER:
            return state.user = action.payload
        default:
            return state
    }
}