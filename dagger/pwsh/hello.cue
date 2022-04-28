package hello

import(
    "dagger.io/dagger"
    "dagger.io/dagger/core"
    "universe.dagger.io/powershell"
)

dagger.#Plan & {
    _srcMount: "/src/pwsh_module" : {
        dest: "/src/pwsh_module"
        type: "cache"
        contents: core.#CacheDir & {
            id: "powershell-module-cache"
        }
    }
    client: {
        filesystem: {
            "./" : read: {
                contents: dagger.#FS
            }
        }
        env: {
            APP_NAME: string | *"HELLO_WORLD"
            GREETING: string | *"Hello"
        }
    }

    actions: {
        //image: core.#Pull & {
        //    source: "mcr.microsoft.com/azure-powershell:latest"
        //}

        hello: powershell.#Run & {
            directory: client.filesystem."/"
            filename: hello.ps1
            always: true
    }
    }

}