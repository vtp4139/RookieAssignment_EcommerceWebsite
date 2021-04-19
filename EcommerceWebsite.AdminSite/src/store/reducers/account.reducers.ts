import { AccountActionTypes, AccountState, LOGIN_FAILURE, LOGIN_REQUEST, LOGIN_SUCCESS } from "../contains/account.types";

const InitSate: AccountState = {
    access_token: '',
    refresh_token: '',
    expires_in: 0,
    error: ''
}

const AccountReducer = (
    state: AccountState = InitSate,
    action: AccountActionTypes
): AccountState => {
    switch (action.type) {
        case LOGIN_REQUEST: {
            return {
                ...state //Return value type
            }
        }

        case LOGIN_SUCCESS: {
            return {
                ...state,
                access_token: action.payload.access_token,
                refresh_token: action.payload.refresh_token,
                expires_in: action.payload.expires_in
            }
        }

        case LOGIN_FAILURE: {
            return {
                ...state,
                error: action.payload.error
            }
        }

        default:
            return state;

    }
}
export default AccountReducer;