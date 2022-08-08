﻿using MelonLoader;
using System;
using WasmLoader;
using WasmLoader.Refs;
using UnityEngine;
using Wasmtime;

[assembly: MelonInfo(typeof(WasmLoaderMod), "WasmLoader", "1.0.1", "Eric van Fandenfart")]
[assembly: MelonGame]

namespace WasmLoader
{

    public class WasmLoaderMod : MelonMod
    {
        private Engine engine;
        private Linker linker;
        private Store store;
        private Objectstore objects;
        private Module module;
        private Instance instance;

        public static WasmLoaderMod Instance;

        public WasmLoaderMod()
        {
            Instance = this;
        }

        public void Setup()
        {
            if (store != null)
            {
                store.Dispose();
                store = null;
            }
            if (linker != null)
            {
                linker.Dispose();
                linker = null;
            }
            if (module != null)
            {
                module.Dispose();
                module = null;
            }
            if (engine != null)
            {
                engine.Dispose();
                engine = null;
            }
            engine = new Engine();
            module = Module.FromTextFile(engine, "memory.wat");
            linker = new Linker(engine);
            store = new Store(engine);
            objects = new Objectstore(store);
            new GameObject_Ref().Setup(linker, store, objects);
            new Log().Setup(linker, store, objects);


            instance = linker.Instantiate(store, module);


            LoggerInstance?.Msg("Loaded WASM");

        }

        public void Excute(string method)
        {
            instance.GetAction(store, method)?.Invoke();
        }

        public override void OnApplicationStart()
        {
            Setup();
            Excute("OnApplicationStart");
        }


        public override void OnApplicationLateStart()
        {
            Excute("OnApplicationLateStart");
        }

        public override void OnUpdate()
        {

            Excute("OnUpdate");

            if (Input.GetKeyDown(KeyCode.P))
            {
                Excute("Teleport");
            }
            if (Input.GetKeyDown(KeyCode.O))
            {
                Excute("ToggleMirror");
            }
            if (Input.GetKeyDown(KeyCode.I))
            {
                Excute("ToggleMirror2");
            }
            if (Input.GetKeyDown(KeyCode.U))
            {
                Excute("Test");
            }
            if (Input.GetKeyDown(KeyCode.Z))
            {
                Excute("Test2");
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                Excute("FizzBuzz");
            }
        }

        public override void OnLateUpdate()
        {
            Excute("OnLateUpdate");
        }
    }
}