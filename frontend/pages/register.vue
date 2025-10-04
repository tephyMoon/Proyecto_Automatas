<script setup lang="ts">
definePageMeta({ layout: 'public' })

/**
 * Registro maquetado (sin conexión a backend).
 * 🔌 Futuro:
 *  - POST /users
 *  - Subida de foto (original + modificada con filtros)
 *  - Generación de credencial PDF con QR (backend)
 */
const step = ref(1)
const form = reactive({
  email: '',
  phone: '',
  birth: '',
  nickname: '',
  password: '',
  notify: 'correo',
  photo: null as File | null
})

const next = () => step.value++
const prev = () => step.value--

const handleFakeRegister = async () => {
  await new Promise(r => setTimeout(r, 700))
  navigateTo('/dashboard')
}
</script>

<template>
  <div class="w-full max-w-2xl space-y-6">
    <h2 class="text-2xl font-semibold">Registro de usuario</h2>

    <div class="p-4 rounded-2xl border border-primary bg-primary/20 space-y-3">
      <div v-if="step === 1" class="grid md:grid-cols-2 gap-3">
        <input v-model="form.email" placeholder="Correo electrónico" class="px-3 py-2 rounded-lg bg-primary/50 border border-primary" required />
        <input v-model="form.phone" placeholder="Teléfono" class="px-3 py-2 rounded-lg bg-primary/50 border border-primary" required />
        <input v-model="form.birth" type="date" placeholder="Fecha de nacimiento" class="px-3 py-2 rounded-lg bg-primary/50 border border-primary" required />
        <input v-model="form.nickname" placeholder="Nickname" class="px-3 py-2 rounded-lg bg-primary/50 border border-primary" required />
        <input v-model="form.password" type="password" placeholder="Contraseña" class="px-3 py-2 rounded-lg bg-primary/50 border border-primary" required />
      </div>

      <div v-else-if="step === 2" class="space-y-3">
        <div class="text-sm opacity-80">Método de notificación</div>
        <div class="flex gap-3">
          <label class="flex items-center gap-2"><input type="radio" value="correo" v-model="form.notify" /> Correo</label>
          <label class="flex items-center gap-2"><input type="radio" value="whatsapp" v-model="form.notify" /> WhatsApp</label>
          <label class="flex items-center gap-2"><input type="radio" value="ambos" v-model="form.notify" /> Ambos</label>
        </div>
        <div class="text-sm opacity-70">Toma de fotografía y filtros se integran con backend.</div>
        <input type="file" accept="image/*" class="px-3 py-2 rounded-lg bg-primary/50 border border-primary" />
      </div>

      <div v-else class="space-y-2">
        <p class="opacity-80 text-sm">Revisión rápida de datos. Al continuar, se simula el registro.</p>
        <button class="px-4 py-2 rounded-lg bg-accent/80 hover:bg-accent/90" @click="handleFakeRegister">Finalizar</button>
      </div>

      <div class="flex items-center justify-between pt-2">
        <button class="px-4 py-2 rounded-lg border border-primary" :disabled="step===1" @click="prev">Atrás</button>
        <button class="px-4 py-2 rounded-lg bg-accent/80 hover:bg-accent/90" v-if="step<3" @click="next">Siguiente</button>
      </div>
    </div>
  </div>
</template>
