import {SET_USER} from "./../constans/user.types"

export const SetUser = (user) => {
    return {
        type: SET_USER,
        payload: user
    }
}